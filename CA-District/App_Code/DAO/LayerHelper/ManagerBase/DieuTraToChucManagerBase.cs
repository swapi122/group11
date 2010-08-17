




/*
'===============================================================================
'  LayerHelper.CAQ.BL.DieuTraToChucManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class DieuTraToChucManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DieuTraToChucManagerBase()
		{
			// Nothing for now.
		}
		
		public DieuTraToChucEntity Insert(DieuTraToChucEntity _DieuTraToChucEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DieuTraToChucEntity, true);
			}
			return _DieuTraToChucEntity;
		}

		
		public DieuTraToChucEntity Insert(Guid Id, Guid IdToChuc, DateTime NgayTienHanh, string NoiDungDieuTra, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			DieuTraToChucEntity _DieuTraToChucEntity = new DieuTraToChucEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DieuTraToChucEntity.Id = Id;
				_DieuTraToChucEntity.IdToChuc = IdToChuc;
				_DieuTraToChucEntity.NgayTienHanh = NgayTienHanh;
				_DieuTraToChucEntity.NoiDungDieuTra = NoiDungDieuTra;
				_DieuTraToChucEntity.MaRutGon = MaRutGon;
				_DieuTraToChucEntity.MaTp = MaTp;
				_DieuTraToChucEntity.GhiChu = GhiChu;
				_DieuTraToChucEntity.IdNguoiTao = IdNguoiTao;
				_DieuTraToChucEntity.NgayTao = NgayTao;
				_DieuTraToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DieuTraToChucEntity.NgayCapNhat = NgayCapNhat;
				_DieuTraToChucEntity.NgayHetHan = NgayHetHan;
				_DieuTraToChucEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DieuTraToChucEntity, true);
			}
			return _DieuTraToChucEntity;
		}

		public DieuTraToChucEntity Insert(Guid IdToChuc, DateTime NgayTienHanh, string NoiDungDieuTra, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			DieuTraToChucEntity _DieuTraToChucEntity = new DieuTraToChucEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DieuTraToChucEntity.IdToChuc = IdToChuc;
				_DieuTraToChucEntity.NgayTienHanh = NgayTienHanh;
				_DieuTraToChucEntity.NoiDungDieuTra = NoiDungDieuTra;
				_DieuTraToChucEntity.MaRutGon = MaRutGon;
				_DieuTraToChucEntity.MaTp = MaTp;
				_DieuTraToChucEntity.GhiChu = GhiChu;
				_DieuTraToChucEntity.IdNguoiTao = IdNguoiTao;
				_DieuTraToChucEntity.NgayTao = NgayTao;
				_DieuTraToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DieuTraToChucEntity.NgayCapNhat = NgayCapNhat;
				_DieuTraToChucEntity.NgayHetHan = NgayHetHan;
				_DieuTraToChucEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DieuTraToChucEntity, true);
			}
			return _DieuTraToChucEntity;
		}

		public bool Update(DieuTraToChucEntity _DieuTraToChucEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DieuTraToChucFields.Id == _DieuTraToChucEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DieuTraToChucEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DieuTraToChucEntity _DieuTraToChucEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DieuTraToChucEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdToChuc, DateTime NgayTienHanh, string NoiDungDieuTra, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DieuTraToChucEntity _DieuTraToChucEntity = new DieuTraToChucEntity(Id);
				if (adapter.FetchEntity(_DieuTraToChucEntity))
				{
				
					_DieuTraToChucEntity.IdToChuc = IdToChuc;
					_DieuTraToChucEntity.NgayTienHanh = NgayTienHanh;
					_DieuTraToChucEntity.NoiDungDieuTra = NoiDungDieuTra;
					_DieuTraToChucEntity.MaRutGon = MaRutGon;
					_DieuTraToChucEntity.MaTp = MaTp;
					_DieuTraToChucEntity.GhiChu = GhiChu;
					_DieuTraToChucEntity.IdNguoiTao = IdNguoiTao;
					_DieuTraToChucEntity.NgayTao = NgayTao;
					_DieuTraToChucEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_DieuTraToChucEntity.NgayCapNhat = NgayCapNhat;
					_DieuTraToChucEntity.NgayHetHan = NgayHetHan;
					_DieuTraToChucEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_DieuTraToChucEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DieuTraToChucEntity _DieuTraToChucEntity = new DieuTraToChucEntity(Id);
				if (adapter.FetchEntity(_DieuTraToChucEntity))
				{
					adapter.DeleteEntity(_DieuTraToChucEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdToChuc(Guid IdToChuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTienHanh(DateTime NgayTienHanh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiDungDieuTra(string NoiDungDieuTra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraToChucEntity", filter);
			}
			return toReturn;
		}
		

		
		public DieuTraToChucEntity SelectOne(Guid Id)
		{
			DieuTraToChucEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DieuTraToChucEntity _DieuTraToChucEntity = new DieuTraToChucEntity(Id);
				if (adapter.FetchEntity(_DieuTraToChucEntity))
				{
					toReturn = _DieuTraToChucEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectAllLST()
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, null, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByIdToChucLST(Guid IdToChuc)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByIdToChucLST_Paged(Guid IdToChuc, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdToChucRDT(Guid IdToChuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdToChucRDT_Paged(Guid IdToChuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdToChuc == IdToChuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNgayTienHanhLST(DateTime NgayTienHanh)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNgayTienHanhLST_Paged(DateTime NgayTienHanh, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTienHanhRDT(DateTime NgayTienHanh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTienHanhRDT_Paged(DateTime NgayTienHanh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNoiDungDieuTraLST(string NoiDungDieuTra)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNoiDungDieuTraLST_Paged(string NoiDungDieuTra, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungDieuTraRDT(string NoiDungDieuTra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungDieuTraRDT_Paged(string NoiDungDieuTra, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return EntityCollection<DieuTraToChucEntity>
		public EntityCollection<DieuTraToChucEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraToChucEntity> _DieuTraToChucCollection = new EntityCollection<DieuTraToChucEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraToChucCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraToChucCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraToChucCollection = new EntityCollection(new DieuTraToChucEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraToChucFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraToChucCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
