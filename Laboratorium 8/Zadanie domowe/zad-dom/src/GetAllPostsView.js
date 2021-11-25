import React, { useEffect, useState } from 'react';
import { Table, Menu, Dropdown, Button, Modal } from 'antd';
import { SettingFilled } from '@ant-design/icons';
import PostForm from './PostForm';

const GetAllPostsView = ({ data, deletePost, updatePost }) => {
	const [localData, setLocalData] = useState(data);
	const [isDataFetching, setDataFetching] = useState([]);
	const [showDeleteModal, setShowDeleteModal] = useState(false);
	const [showUpdateModal, setShowUpdateModal] = useState(false);
	const [selectedPost, setSelectedPost] = useState(null);
	const [useEffectInvoker, setUseEffectInvoker] = useState(false);

	// Deleting Post
	const handleShowDeleteModal = (postInfo) => {
		return () => {
			console.log(postInfo);
			setSelectedPost(postInfo);
			setShowDeleteModal(true);
		};
	};

	const handleDeleteFinish = () => {
		deletePost(selectedPost);
		closeDeleteModal();
		setUseEffectInvoker(!useEffectInvoker);
		setDataFetching(false);
	};

	const closeDeleteModal = () => setShowDeleteModal(false);

	// Updating Post
	const handleShowUpdateModal = (postInfo) => {
		return () => {
			setSelectedPost(postInfo);
			setShowUpdateModal(true);
		};
	};

	const handleUpdateFinish = (values) => {
		updatePost(values);
	};

	const closeUpdateModal = () => setShowUpdateModal(false);

	useEffect(() => {
		setDataFetching(true);
		console.log(data);
		setLocalData(data);
		setDataFetching(true);
		setDataFetching(false);
	}, []);

	const menu = (post) => (
		<Menu>
			<Menu.Item key='1' onClick={handleShowUpdateModal([post])}>
				Edytuj
			</Menu.Item>
			<Menu.Item key='2' onClick={handleShowDeleteModal(post)}>
				Usuń
			</Menu.Item>
		</Menu>
	);

	const columns = [
		{
			title: 'Id Użytkownika',
			dataIndex: 'userId'
		},
		{
			title: 'Id Posta',
			dataIndex: 'id'
		},
		{
			title: 'Tytuł',
			dataIndex: 'title'
		},
        {
			title: 'Opis',
			dataIndex: 'body'
		},
		{
			title: 'Opcje',
			align: 'center',
			render: (data) => (
				<Dropdown placement='bottomCenter' trigger='click' overlay={menu(data)}>
					<Button type='link' icon={<SettingFilled />} />
				</Dropdown>
			)
		}
	];

	return (
		<div>
			<h1 className='text-center m-3 font-display'>Posts Menu!</h1>
			<Table size='large' columns={columns} dataSource={localData} rowKey={(d) => d.id} loading={isDataFetching} />
			<Modal visible={showUpdateModal} onCancel={closeUpdateModal}>
				<h1>Edytuj post</h1>
				<PostForm initialValues={selectedPost} submitText='Zapisz!' onFinish={handleUpdateFinish} />
			</Modal>
			<Modal visible={showDeleteModal} onCancel={closeDeleteModal} onOk={handleDeleteFinish} >
				Czy checesz usunąć Post?
			</Modal>
		</div>
	);
};

export default GetAllPostsView;